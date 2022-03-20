  /* Очистка області виводу результатів */
  function Clear()
  {
    document.getElementById('ResultArea').innerHTML='';
  }


  /* Стартова ініціалізація */
  function Initialize()
  {
    Clear();
    var s="<table id='TableFunction'><tr>";
    s+="<td class='TableFunctionCell' align='center' valign='top'>"+"<div class='function'>Булева функція</div>"+KZBoolFun(1)+CreateBoolFunTable(1,true)+"</td>";
    s+="</tr></table>";
    document.getElementById('Function').innerHTML=s;
    var kzF=eval(document.getElementById('kzF').value);  //кiлькiсть змінних функції
    var vector = "";
    for(i=1;i<=kzF;i++)
    {
      vector+="<input type='button' value='0' id='vzn"+i+"' class='BFValue' onClick='this.value=ChangeValue(this.value);Clear();'>&nbsp;";
    }
    document.getElementById('vector').innerHTML = vector;
  }


  /* Генерування коду перемикача кількості змінних булевої функції */
  function KZBoolFun(start)
  // start - стартове значення перемикача
  {
    var tmp="<nobr>Кiлькiсть змiнних:</nobr><br><table><tr><td><input class='kzF' id='kzF' type='button' value='"+start+"' disabled></td>";
    tmp+="<td><input type='button' value='&#9650;' class='switcher' onClick=ChangeBoolFun('+');><br>";
    tmp+="<input type='button' value='&#9660;' class='switcher' onClick=ChangeBoolFun('-');></td></tr></table>";
    return tmp;
  }


  /* Генерування коду таблиці істинності булевої функції */
  function CreateBoolFunTable(k,flag)
  // k - кількість змінних цієї функції
  // flag (true або false)  - індикатор необхідності створення контейнера-обгортки з ідентифікатором
  {
    var i, j, n=Math.pow(2,k);  //кiлькiсть двiйкових наборiв

    // формування аналітичного запису повної назви функцiї
    var F_name='F';
    if (k!=0)
    {
      F_name+='(';
      for(j=1;j<=k-1;j++)
      {
        F_name+='x<sub>'+j+'</sub>,';
      }
      F_name+='x<sub>'+k+'</sub>)';
    }

    // генерування коду таблицi iстинностi
    var TableCode="<table class='TableBF'><tr>";
    for(j=1;j<=k;j++)
    {
      TableCode+='<th>x<sub>'+j+'</sub></th>';
    }
    TableCode+='<th>'+F_name+'</th></tr>';
    for(i=1;i<=n;i++)
    {
      TableCode+='<tr>';
      for(j=1;j<=k;j++)
      {
        TableCode+='<th>'+GenerateDN(i-1,k).charAt(j-1)+'</th>';
      }
      TableCode+='<th>'+"<input type='button' value='0' id=Fzn"+i+" class='BFValue' onClick='this.value=ChangeValue(this.value);Clear();'>"+'</th></tr>';
    }
    TableCode+='</table>';
    if (flag) { TableCode="<div id='F'>"+TableCode+"</div>"; }

    return TableCode;
  }


  /* Функція, що повертає нове значення для комірки зі значенням булевої функції (після кліку на ній) */
  function ChangeValue(start)
  // start - стартове значення комірки
  {
    switch (start) {
     case '0': tmp='1';break;
     case '1': tmp='0';break;
     default: ;
    }
    return tmp;
  }


  /* Обробка зміни (на 1) кількості змінних функції */
  function ChangeBoolFun(flag)
  // flag (+ або -) - індикатор потрібної зміни (на 1) кiлькостi змінних
  {
    Clear();
    var tmp=document.getElementById('kzF');
    var k=eval(tmp.value);  //кiлькiсть змінних функцiї
    if (flag=='+')
    {
      if (k<100) {tmp.value=k+1; k++;}
    }
    else
    {
      if (k>1) {tmp.value=k-1; k--;}
    }
   document.getElementById('F').innerHTML=CreateBoolFunTable(k,false);

   var vector = "";
   for(i=1;i<=k;i++)
   {
     vector+="<input type='button' value='0' id='vzn"+i+"' class='BFValue' onClick='this.value=ChangeValue(this.value);Clear();'>&nbsp;";
   }
   document.getElementById('vector').innerHTML = vector;
  }


  /*  Заповнення ствопчика значень булевої функції потрібним значенням */
  function SetAll(flag)
  // flag - значення, яким потрібно заповнити весь стовпчик значень булевої функції
  {
    var i, n=Math.pow(2,document.getElementById('kzF').value);  //кiлькiсть двiйкових наборiв
    for(i=1;i<=n;i++)
    {
      document.getElementById('Fzn'+i).value=flag;
      Clear();
    }
  }

  /*  Заповнення вектора поляризації потрібним значенням */
  function SetAllVP(flag)
  // flag - значення, яким потрібно заповнити вектор поляризації
  {
    var i, k=eval(document.getElementById('kzF').value);  //кiлькiсть змінних функцiї
    for(i=1;i<=k;i++)
    {
      document.getElementById('vzn'+i).value=flag;
      Clear();
    }
  }


  /* Побудова поляризованого поліному Ріда-Маллера */
  function FindPolinom()
  {
    var i, j, f, q;

    var n=eval(document.getElementById('kzF').value);  //кiлькiсть змінних функції
    var k=Math.pow(2,n);  //кiлькiсть двiйкових наборiв

    f = new Array(k);

    // зчитування стовпчика значень функції
    for(i=0;i<=k-1;i++) {
      f[i]=document.getElementById('Fzn'+eval(i+1)).value;
    }

    q = new Array(n);

    // зчитування вектора поляризації
    for(j=0;j<=n-1;j++) {
      q[j]= eval(document.getElementById('vzn'+eval(j+1)).value);
    }


    // ...  реалізація побудови поляризованого поліному Ріда-Маллера ...
    var A=new Array(k);
    for(i=0;i<k;i++)
    {
      A[i]=new Array(n);
    }

    var Af=new Array(k);
    for(i=0;i<k;i++)
    {
      Af[i]=new Array(n+1);
    }
    var Aq=new Array(k);
    for(i=0;i<k;i++)
    {
      Aq[i]=new Array(n+1);
    }
            var zeroFunct = 0;
            var oneFunct = 0;
            //var s = " ";
            //var s="";
            let stringRes=new String();
            stringRes=" ";

            for ( i = 0; i < k; i++)
            {
                f[i] =document.getElementById('Fzn'+eval(i+1)).value;;
                if(f[i]==0)
                {
                    zeroFunct += 1;
                }
                else
                {
                    oneFunct += 1;
                }
            }

            if(zeroFunct==k)
            {
                stringRes += "0";
                //return s;
            }

            else if(oneFunct==k)
            {
                stringRes += "1";
                //return s;
            }

           /* for (int i = 0; i < n; i++)
            {
                q[i] =Convert.ToInt32(dgvVector[i,1].Value);
            }*/
          else{
            var step, k1 = k - 1;
            for ( i = 0; i < n; i++)
            {
                step = (Math.pow(2, (n - 1 - i)));
                j = 0;
                while (j <= Math.pow(2, n) - 1)
                {
                    while (step >= 1)
                    {
                        A[j][i] = Af[j][i] = Aq[j][i] = 0;
                        j++;
                        step--;
                    }
                    step = (Math.pow(2, (n - 1 - i)));
                    while (step >= 1)
                    {
                        A[j][i] = Af[j][i] = Aq[j][i] = 1;
                        j++;
                        step--;
                    }
                    step = (Math.pow(2, (n - 1 - i)));
                }
            }


            for ( i = 0; i < Math.pow(2, n); i++)
            {
                Af[i][n] = f[i];
            }

            for ( i = 0; i < Math.pow(2, n); i++)
            {
               var temp1=new Array(n);
                for (j1 = 0; j1 < n; j1++)
                {
                    if (q[j1] == 1)
                    {
                        /*if (Aq[i][j1] === 0) {
                            temp1[j1] = 1;
                        }
                        else
                        {
                            temp1[j1] = 0;
                        }*/
                        Aq[i][j1] === 0 ? temp1[j1] =1: temp1[j1]=0;
                    }
                    else
                    {
                        temp1[j1] = Aq[i][j1];
                    }
                }





                for (t = 0; t < Math.pow(2, n); t++) {
                    var m = 0;
                    if (m >= n)
                    { break; }

                    while (Af[t][m] == temp1[m]) {
                        m++;
                        if (m >= n)
                        { break; }
                    }
                   if (m == n )
                    {
                        Aq[i][n] = Af[t][n];
                        break;
                    }
                }

            }

            var l = (Math.pow(2, n));
            var mas = new Array(l);
            var res = new Array(l);
            var kount = 0;
            var temp = (Math.pow(2, n));
            for (i = 0; i < Math.pow(2, n); i++)
            {
                mas[i] = Aq[i][n];
            }

            res[kount] = mas[kount];
            kount++;
            while (temp >= 1)
            {
                var t = new Array(temp);
                var t2 = new Array(temp-1);
                t = mas;
                for (i = 0; i < temp - 1; i++)
                {
                    if (t[i] != t[i + 1])
                    { t2[i] = 1; }
                    else
                    { t2[i] = 0; }
                }
                res[kount] = t2[0];
                kount++;

                if (kount >= l)
                    {break;}
                mas = t2;
                temp--;

            }

           var x = new Array(n);
            for (i = 0; i < n; i++){
                if (q[i] == 1){
                   x[i]= '<span class="invertedvar">x</span><sub>'+(i+1)+'</sub>';
                  }
                else{
                    x[i]='<span class="normalvar">x</span><sub>'+(i+1)+'</sub>';
                }
            }
            //let stringRes=new String();
            if (res[0] == 1){ stringRes += "1+"; }
            for (i = 1; i < Math.pow(2, n); i++)
            {
                if (res[i] != 0)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (A[i][j] != 0)
                        {
                          stringRes = stringRes + x[j];
                        }
                    }
                    stringRes = stringRes+ "+";
                }
            }
            stringRes=stringRes.substring(0, stringRes.length - 1);
            /*if(stringRes.length==0){
              stringRes="0"
            }*/
          }

    document.getElementById('ResultArea').innerHTML='<br>';
    document.getElementById('ResultArea').innerHTML+='Поляризований поліном Ріда-Маллера:'+'<br>';

    document.getElementById('ResultArea').innerHTML+='<br>';
    document.getElementById('ResultArea').innerHTML+="P <sub>"+q.join('')+"</sub> (F) ="+stringRes+'<br>';
    //document.getElementById('ResultArea').innerHTML+="P <sub>"+q.join('')+"</sub> (F) = ("+f.join('')+') ='+stringRes+'<br>';
    //document.getElementById('ResultArea').innerHTML+='<br>Приклад виводу якоїсь елементарної кон\'юнкції: '+stringRes;
  }


  /* Генерування двійкового набору заданої розмірності за його десятковим еквівалентом */
  function GenerateDN(number,size)
  // number - десятковий еквівалент двійкового набору
  // size - розмірність двійкового набору
  {
    var i, tmp=(number).toString(2);
    var count=size-tmp.length;
    for(i=1;i<=count;i++)
    {
      tmp="0"+tmp;
    }
    return tmp;
  }
