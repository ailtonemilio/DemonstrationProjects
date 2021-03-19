// start Bootstrap ---------------------------------------------------------------------------------------------------------------------------
function Closepopup(nameModal) {
    var Modall = '#' + nameModal;
    $(Modall).modal('hide');
}

function ShowMessage(message, messagetype) {
    var cssclass;
    switch (messagetype) {
        case 'Success':
            cssclass = 'alert-success'
            break;
        case 'Error':
            cssclass = 'alert-danger'
            break;
        case 'Warning':
            cssclass = 'alert-warning'
            break;
        default:
            cssclass = 'alert-info'
    }
    $('#alert_container').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert fade in ' + cssclass + '"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');

    setTimeout(function () {
        $("#alert_div").fadeTo(2000, 500).slideUp(500, function () {
            $("#alert_div").remove();
        });
    }, 2000);
    //5000=5 seconds
}

// End Bootstrap ----------------------------------------------------------------------------------------------------------------------

//---------------------------------------------------- Start Sweet Alert -------------------------------------------------------------
function sweetalert(title1, message, type1) {
    swal({
        title: title1,
        text: message,
        type: type1
    });
}
//---------------------------------------------------- End Sweet Alert -------------------------------------------------------------

//------------------------------------------------------------------

function ConfirmDelete()
{
    return confirm('Do you really want to delete this record?');
}
function AlertExclusion() {
    return confirm('Delete this record can cause damage to the visibilities contact the Project Administrator?');
}
function ToUpper(e)
{
    //e.value = e.value.toUpperCase();
    var keynum;

    // IE
    if (window.event) {
        keynum = event.keyCode;
    }
    // Netscape/Firefox/Opera
    else if (event.which) {
        keynum = event.which;
    }

    if ((keynum >= 97 && keynum <= 122) || (keynum >= 224 && keynum <= 255)) {
        // converte de acordo com o valor decimal da tecla na tabela ascii    
        keynum = keynum - 32;

        // IE
        if (window.event) {
            window.event.keyCode = keynum;
        }
        // firefox e outros que usam o Gecko
        else if (event.which) {
            var newEvent = document.createEvent("KeyEvents");
            newEvent.initKeyEvent("keypress", true, true, document.defaultView,
                        event.ctrlKey, event.altKey, event.shiftKey,
                        event.metaKey, 0, keynum);
            event.preventDefault();
            event.target.dispatchEvent(newEvent);
        }
    }

    return true;

}
//Formata Data
function FormatDate(controle, teclapres) 
{
   CampoNumerico(teclapres)
    if (event.keyCode != 0 || event.keyCode != 9)
    {
        var tecla = teclapres.keyCode;
	    vr = controle.value;
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( "/", "" );
	    vr = vr.replace( "/", "" );
	    tam = vr.length + 1;
        
        if (tam <= 6)
        {
	        if ( tecla != 9 && tecla != 8 ){
		        if ( tam > 2 && tam < 5 )
			        controle.value = vr.substr( 0, tam - 2  ) + '/' + vr.substr( tam - 2, tam );
		        if ( tam >= 5 && tam <= 10 )
			        controle.value = vr.substr( 0, 2 ) + '/' + vr.substr( 2, 2 ) + '/' + vr.substr( 4, 4 ); }
		}
    }
	
}
//Formata Telefone
function FormatPhone(controle,teclapres)
{
    CampoNumerico(teclapres)
    if (event.keyCode !=0)
    {
        var tecla = teclapres.keyCode;
        fone = controle.value;
        fone = fone.replace(".","");
        fone = fone.replace("-","");
        Tam = fone.length + 1;
        if (tecla != 9 && tecla != 8)
        {
            if (Tam == 5)
            {
                controle.value = fone + '-';
            }
        }
    }
}
//Formata CEP para o Brazil
function FormataCEP(controle,teclapres)
{
    CampoNumerico(teclapres);
    if (event.keyCode !=0)
    {
        var tecla = teclapres.keycode;
        CEP = controle.value;
        CEP = CEP.replace(".","");
        CEP = CEP.replace("-","");
        Tam = CEP.lenght + 1;
        if (tecla !=9 && tecla!=8)
        {
            if (Tam == 2)
            {
                controle.value = CEP + '.';
            }
            if (Tam == 6)
            {
                controle.value = CEP + '-';
            }
        }
    }
}
//******************************************************************************************************************************
// Verificação  CPF para o Brazil
//******************************************************************************************************************************

function ValidarCPF(Controle){
	
	var 
		char_valido = 0, 
		char_invalido = 0, 
		digito1, 
		digito2,msgaux,texto,erro,
		soma_digito1 = 0,
		soma_digito2 = 0;
	  
		msgaux = 'Erro encontrado no campo CPF:\n' 
		erro=false;

		//verifica sequencia de numeros repetidos.
		
		if (Controle.value.length==0)
			return true;		
			
					    
	    while (Controle.value.length<11)
	        Controle.value=0+Controle.value;	
		 
		if (Controle.value.length>11)
		{
		  msgaux+='\n- Valor incorreto;'
		  erro=true;      
		}
			
		if (Controle.value == '00000000000' || Controle.value == '11111111111' ||
	    	Controle.value == '22222222222' || Controle.value == '33333333333' ||
			Controle.value == '44444444444' || Controle.value == '55555555555' ||
			Controle.value == '66666666666' || Controle.value == '77777777777' || 
			Controle.value == '99999999999')
					
			{
				msgaux+='\n- Valor incorreto;'
				erro=true;
			}
			
			//verifica quantidade de caracteres
				
			if (Controle.value.length == 11)
			{
					
				//verifica se digitou apenas números
					
				for (var i = 0; i <= Controle.value.length - 1; i++)
					{
					if (Controle.value.charAt(i) >= '0' && Controle.value.charAt(i) <= '9')
						{
							char_valido = char_valido + 1;
						}
					else
						{
							char_invalido = char_invalido + 1;
						}
					}
      
				if (char_valido == Controle.value.length)
					{
					for (i = 0; i < 9; i++)
						{
							soma_digito1 += (10 - i) * (eval(Controle.value.charAt(i)));
						}
						digito1 = 11 - (soma_digito1 % 11);
						
						for (i = 0; i < 9; i++)
							{
								soma_digito2 += (11 - i) * (eval(Controle.value.charAt(i)));
							}		
						
						soma_digito2 += 2 * (eval(Controle.value.charAt(9)));
								
						digito2 = 11 - (soma_digito2 % 11);
								
						if ((soma_digito1 % 11) < 2)
							{
								digito1 = 0;
							}
						
						if ((soma_digito2 % 11) < 2)
							{
								digito2 = 0;
							}
						
						if (eval(Controle.value.charAt(9) != digito1) || eval(Controle.value.charAt(10) != digito2))
							{
								msgaux+='\n- Valor incorreto;'
								erro=true;
							}
						}
					else
						{
							msgaux+='\n- Digite apenas numeros;'
							erro=true;
						}
					}

			if (erro)
			{ 	
			    alert(msgaux);			    			    						
				Controle.focus();				 								
				return false;				
			}

			return !(erro);
		
		}

//************************************************************************
// Verificar CNPJ para o Brazil
//************************************************************************
		
function ValidarCNPJ(Controle)
			{	
				var 
					char_valido = 0, 
					char_invalido = 0, 
					digito1, 
					digito2,
					soma_digito1 = 0,
					soma_digito2 = 0;
					msgaux='Erros encontrados no campo CNPJ:\n';
					erro = false;

					Controle.value = Controle.value.replace(".","");
					Controle.value = Controle.value.replace(".","");
					Controle.value = Controle.value.replace(".","");
					Controle.value = Controle.value.replace(".","");
					Controle.value = Controle.value.replace(".","");
					Controle.value = Controle.value.replace(",","");
					Controle.value = Controle.value.replace(",","");
					Controle.value = Controle.value.replace(",","");
					Controle.value = Controle.value.replace(",","");
					Controle.value = Controle.value.replace(",","");
					Controle.value = Controle.value.replace("-","");
					Controle.value = Controle.value.replace("-","");
					Controle.value = Controle.value.replace("-","");
					Controle.value = Controle.value.replace("-","");
					Controle.value = Controle.value.replace("-","");
					Controle.value = Controle.value.replace("/","");
					Controle.value = Controle.value.replace("/","");
					Controle.value = Controle.value.replace("/","");
					Controle.value = Controle.value.replace("/","");
					Controle.value = Controle.value.replace("/","");
			
					if (Controle.value!="")    
				    {
				         while (Controle.value.length<14)
	                        Controle.value=0+Controle.value;	
                		
                		//verifica quantidade de caracteres 
		                if (Controle.value.length>14)
		                {
		                  msgaux+='\n- Valor incorreto;'
		                  erro=true;      
		                }
		                
					    //verifica sequencia de caracteres repetidos							
						if (Controle.value.length == 14)
						{
						if (Controle.value == '00000000000000' || Controle.value == '11111111111111' ||
						    Controle.value == '22222222222222' || Controle.value == '33333333333333' ||
							Controle.value == '44444444444444' || Controle.value == '55555555555555' ||
							Controle.value == '66666666666666' || Controle.value == '77777777777777' ||
							Controle.value == '88888888888888' || Controle.value == '99999999999999')							
						{
						    msgaux+='CNPJ invalido;\n';
							erro = true;
						}	
									
						if (erro == false){
						    //verifica se digitou apenas números
							for (var i = 0; i <= Controle.value.length - 1; i++)
							{
							    if (Controle.value.charAt(i) >= '0' && Controle.value.charAt(i) <= '9')
								{
								    char_valido = char_valido + 1;
								}
								else
								{
								    char_invalido = char_invalido + 1;
								}
							}
			     
							if (char_valido == Controle.value.length)
							{
							    for (i = 0; i < 4; i++)
								{
								    soma_digito1 += (5 - i) * (eval(Controle.value.charAt(i)));
								}	
								for (i = 0; i < 8; i++)
								{
								    soma_digito1 += (9 - i) * (eval(Controle.value.charAt(i + 4)));
								}
								    digito1 = 11 - (soma_digito1 % 11);
	          
								for (i = 0; i < 5; i++)
								{
								    soma_digito2 += (6 - i) * (eval(Controle.value.charAt(i)));
								}
								for (i = 0; i < 7; i++)
								{
								    soma_digito2 += (9 - i) * (eval(Controle.value.charAt(i + 5)));
								}
								soma_digito2 += 2 * (eval(Controle.value.charAt(12)));
								digito2 = 11 - (soma_digito2 % 11);
	            
								if ((soma_digito1 % 11) < 2)
								{
								    digito1 = 0;
								}
								if ((soma_digito2 % 11) < 2)
								{
								    digito2 = 0;
								}
								if (eval(Controle.value.charAt(12) != digito1) || eval(Controle.value.charAt(13) != digito2))
								{
								    msgaux+='CNPJ invalido;\n';
									erro = true;													
								}
							}
							else
							{
							    msgaux+='Digite apenas números;\n';
								erro = true;
							}
						}
					}
					//else
					//{
					    //msgaux+='Campo CNPJ deve ter 14 digitos;\n';
						//erro = true;
					//}
	
					if (erro == true)
					{						
					    alert(msgaux);							    						
						Controle.focus();															
						return false;
					}
				}
			}


/**************************************************************************/
/*FORMAT HOUR														  */
/**************************************************************************/
function FormatHour(Controle,tammax,teclapres) 
{
    CampoNumerico(teclapres)
    if (event.keyCode != 0)
    {
        var tecla = teclapres.keyCode;
	    vr = Controle.value;
	    vr = vr.replace( "/", "" );
	    vr = vr.replace( "/", "" );
	    vr = vr.replace( ",", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ":", "" );
	    vr = vr.replace( ":", "" );
	    vr = vr.replace( ":", "" );
	    vr = vr.replace( ":", "" );
	    tam = vr.length;

	    if (tam < tammax && tecla != 8){ tam = vr.length + 1 ; }

	    if (tecla == 8 ){	tam = tam - 1 ; }
    		
	    if ( tecla == 8 || tecla >= 48 && tecla <= 57 || tecla >= 96 && tecla <= 105 ){
		    if ( tam <= 2 ){ 
	 		    Controle.value = vr  ; }
	 	    if ( (tam > 2) && (tam <= 4) ){
	 		    Controle.value = vr.substr( 0, tam - 2 ) + ':' + vr.substr( tam - 2, tam ) ; }
    	 	
    	 	
	    }		
    }
}

/**************************************************************************/
/*FORMAT VALUE														  */
/**************************************************************************/

var negativo = false;
function FormataValor(Controle,tammax,teclapres) 
{
    if (teclapres.keyCode != 9) 
    {
        var tecla = teclapres.keyCode;
        
        vr = Controle.value;
	    vr = vr.replace( "/", "" );
	    vr = vr.replace( "/", "" );
	    vr = vr.replace( ",", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    vr = vr.replace( ".", "" );
	    if (vr.indexOf("-") > -1){
	        negativo = true;
	        vr = vr.replace( "-", "" );
	    }
	    else
	    {
	        negativo = false;
	    }
        tam = vr.length;

	    if (tam < tammax && tecla != 8){ tam = vr.length + 1 ; }
    			
	    if ( tecla == 8 || tecla >= 48 && tecla <= 57 || tecla >= 96 && tecla <= 105){
		    if ( tam <= 2 ){ 			 		
	 		    Controle.value = vr ; }
	 	    if ( (tam > 2) && (tam <= 5) ){
	 		    Controle.value = vr.substr( 0, tam - 2 ) + ',' + vr.substr( tam - tammax, tam ) ; }
	 	    if ( (tam >= 6) && (tam <= 8) ){
	 		    Controle.value = vr.substr( 0, tam - 5 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - tammax, tam ) ; }
	 	    if ( (tam >= 9) && (tam <= 11) ){
	 		    Controle.value = vr.substr( 0, tam - 8 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - tammax, tam ) ; }
	 	    if ( (tam >= 12) && (tam <= 14) ){
	 		    Controle.value = vr.substr( 0, tam - 11 ) + '.' + vr.substr( tam - 11, 3 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - tammax, tam ) ; }
	 	    if ( (tam >= 15) && (tam <= 17) ){
	 		    Controle.value = vr.substr( 0, tam - 14 ) + '.' + vr.substr( tam - 14, 3 ) + '.' + vr.substr( tam - 11, 3 ) + '.' + vr.substr( tam - 8, 3 ) + '.' + vr.substr( tam - 5, 3 ) + ',' + vr.substr( tam - tammax, tam ) ;}
    	 		
     	    if (negativo == true)
 	    	    Controle.value = "-" + Controle.value;
	    }
    }
    else
    {
        event.setKeyCode = 9;
    }
}

function Delete(){
	if (confirm('Deseja realmente excluir?')){
		return true;
	}else{
		return false;
	}
}



function OpenPopUPCentral(URL, PopUPWidth, PopUPHeigth)
{
	var Width = window.screen.availWidth;
	var Heigth = window.screen.availHeight;
	
	var WidthLeft = (Width - PopUPWidth) / 2;
	var HeigthTop = (Heigth - PopUPHeigth) / 2;
	
	window.open(URL,'','left='+WidthLeft+',top='+HeigthTop+',width='+PopUPWidth+',height='+PopUPHeigth+', status=yes, scrollbars=yes, menubar=yes');
}
function OpenPopUp(URL, PopUPWidth, PopUPHeigth)
{
    window.open(URL, '', 'width=' + PopUPWidth + ', height=' + PopUPHeigth + ', status=yes, scrollbars=yes, menubar=yes');
}
function OpenfullScreen(URL) {
    var Width = window.screen.availWidth;
    var Heigth = window.screen.availHeight;

    window.open(URL, '', 'width=window.screen.availWidth,height=window.screen.availHeight, status=yes, scrollbars=yes, menubar=no,resizable=1');
}
function OpenModalPopUP(URL, PopUPWidth, PopUPHeigth)
{    	
	var dialogResults = window.showModalDialog(URL,'','DialogWidth='+PopUPWidth+'px;DialogHeight='+PopUPHeigth+'px;status=yes;scrollbars=yes;menubar=yes');
	
	if ( (dialogResults != undefined) && (dialogResults != '') && (dialogResults != false) )
	{ 
	    eval(dialogResults); 
    }
}


function NumericField(e)
{
    if (document.all) // Internet Explorer
        var tecla = event.keyCode;
    else if(document.layers) // Nestcape
        var tecla = e.which;
    if (tecla > 47 && tecla < 58) 
        return true;
    else{
        if ((tecla == 8) || (tecla == 13) || (tecla == 9)) 
            return true;
        else 
            event.keyCode = 0;
        
    }
}


function NegativeNumericField(e)
{
    if (document.all) // Internet Explorer
        var tecla = event.keyCode;
    else if(document.layers) // Nestcape
        var tecla = e.which;
    if ((tecla > 47 && tecla < 58) || (tecla == 45))
        return true;
    else{
        if (tecla != 8) // backspace
        event.keyCode = 0;
        else return true;        
    }
}

function resizeOuterTo(w,h) {
 if (parseInt(navigator.appVersion)>3) {
   if (navigator.appName=="Netscape") {
    top.outerWidth=w;
    top.outerHeight=h;
   }
   else top.resizeTo(w,h);
 }
}

function setHourglass()
{
    document.body.style.cursor = 'wait';
}

function fullScreen() 
{
    window.opener=self;window.open(document.location,'','fullscreen=yes');window.close();
}

function ClearControl(Controle)
{
    Controle.value = '';    
}

function SelectDate(Controle)
{
    now = new Date();
    
    if (Controle.value == '')
    {
        Controle.value = "" + (now.getDate()< 10 ? "0" + now.getDate() : now.getDate()) + "/" + ((now.getMonth() + 1)< 10 ? "0" + (now.getMonth() + 1) : (now.getMonth() + 1)) + "/" + now.getYear()        
    }
        
    Controle.select();
}

function OpenMail(email,assunto,texto)
{

    mailto = "mailto:" + email;  
    if(assunto != '')
        mailto += "?subject=" + assunto;         
         
    if(texto != '')        
        mailto += "&body=" + texto;    
   
    location.href = mailto;    
    return false;
}

function getPageSize()
{
	
	var xScroll, yScroll;
	
	if (window.innerHeight && window.scrollMaxY) {	
		xScroll = window.innerWidth + window.scrollMaxX;
		yScroll = window.innerHeight + window.scrollMaxY;
	} else if (document.body.scrollHeight > document.body.offsetHeight){ // all but Explorer Mac
		xScroll = document.body.scrollWidth;
		yScroll = document.body.scrollHeight;
	} else { // Explorer Mac...would also work in Explorer 6 Strict, Mozilla and Safari
		xScroll = document.body.offsetWidth;
		yScroll = document.body.offsetHeight;
	}
	
	var windowWidth, windowHeight;

	if (self.innerHeight) {	// all except Explorer
		if(document.documentElement.clientWidth){
			windowWidth = document.documentElement.clientWidth; 
		} else {
			windowWidth = self.innerWidth;
		}
		windowHeight = self.innerHeight;
	} else if (document.documentElement && document.documentElement.clientHeight) { // Explorer 6 Strict Mode
		windowWidth = document.documentElement.clientWidth;
		windowHeight = document.documentElement.clientHeight;
	} else if (document.body) { // other Explorers
		windowWidth = document.body.clientWidth;
		windowHeight = document.body.clientHeight;
	}	
	
	// for small pages with total height less then height of the viewport
	if(yScroll < windowHeight){
		pageHeight = windowHeight;
	} else { 
		pageHeight = yScroll;
	}

	// for small pages with total width less then width of the viewport
	if(xScroll < windowWidth){	
		pageWidth = xScroll;		
	} else {
		pageWidth = windowWidth;
	}

	arrayPageSize = new Array(pageWidth,pageHeight,windowWidth,windowHeight) 
	return arrayPageSize;
}

function Loading(visivel)
{      
    if (visivel == 1){
        document.getElementById('Processando').style.display = 'block';
        document.getElementById('Bloqueia').style.display = 'block'; 
        var arrayTamanhoDv = getPageSize();
        document.getElementById('Bloqueia').style.width = arrayTamanhoDv[2];
        document.getElementById('Bloqueia').style.height = arrayTamanhoDv[1];
        //document.getElementById('Bloqueia').focus();    
        document.body.focus();
        
    }
    else{
        document.getElementById('Processando').style.display = 'none';     
        document.getElementById('Bloqueia').style.display = 'none';     
    }  
    
    return true;    
} 
  
// A função abaixo converte um número decimal
// para moeda colocando automatiucamente os ponto e vígulas 
//Para o Brasil Formato
function FormataDecimalToMoeda(num)
{
   x = 0;

   if(num<0) {
      num = Math.abs(num);
      x = 1;
   }   if(isNaN(num)) num = "0";
      cents = Math.floor((num*100+0.5)%100);

   num = Math.floor((num*100+0.5)/100).toString();

   if(cents < 10) cents = "0" + cents;
      for (var i = 0; i < Math.floor((num.length-(1+i))/3); i++)
         num = num.substring(0,num.length-(4*i+3))+'.'
               +num.substring(num.length-(4*i+3));  
                ret = num + ',' + cents;  
                 if (x == 1)
                  ret = ' - ' + ret;
                    return ret;

}	




    // Função que Calcula o Valor das Alícotas dado Um Percentual
    // controleBase: Controle no qual será informado o valor para o cálculo
    // controleRetorno: Controle para qual será retornado o valor resultante cálculo
    // controleValor: Controle no qual deverá conter o Valor Total sobre o qual serão feitos os cálculos
    function CalculaVrAlicota(controleBase,controleRetorno,controleValor)
    {					
        percentBase = document.getElementById(controleBase).value;
        if (percentBase == null || percentBase == '') 
        {
            percentBase = '0';
        }
        percentBase = percentBase.replace(".", "");
        percentBase = percentBase.replace(",", ".");
                
        vrTotal = document.getElementById(controleValor).value;
        if (vrTotal == null || vrTotal == '')
        {
            vrTotal = '0,00';
        }	
        vrTotal = vrTotal.replace(".", "");
        vrTotal = vrTotal.replace(",", ".");
    
        vrAlicotaCalculado = ((parseFloat(percentBase) * parseFloat(vrTotal)) / 100); 
        vrAlicotaCalculado = vrAlicotaCalculado.toFixed(2); 
        vrAlicotaCalculado = vrAlicotaCalculado.toString();
        
        document.getElementById(controleRetorno).value =  FormataDecimalToMoeda(vrAlicotaCalculado);

        if (document.getElementById(controleRetorno).value == 'NaN')
        {
            document.getElementById(controleRetorno).value = '0,00';
        }
       
       return document.getElementById(controleRetorno).value;
    }
    

   // Função que Calcula Um Percentual dado Um Valor  
   // controleBase: Controle no qual será informado o valor para o cálculo
   // controleRetorno: Controle para qual será retornado o valor resultante cálculo
   // controleValor: Controle no qual deverá conter o Valor Total sobre o qual serão feitos os cálculos
    function CalculaPercentual(controleBase,controleRetorno,controleValor)
    {					
        vrBase = document.getElementById(controleBase).value;
        if (vrBase == null) 
        {
            vrBase = '0';
        }
        vrBase = vrBase.replace(".", "");
        vrBase = vrBase.replace(",", ".");
        
        vrTotal = document.getElementById(controleValor).value;
        if (vrTotal == null || vrTotal == '')
        {
            vrTotal = '0,00';
        }	
        vrTotal = vrTotal.replace(".", "");
        vrTotal = vrTotal.replace(",", ".");
    
        percentCalculado = ((parseFloat(vrBase) / parseFloat(vrTotal)) * 100); 
        percentCalculado = percentCalculado.toFixed(2); 
        percentCalculado = percentCalculado.toString();
        
        if ( parseFloat(vrTotal) > 0)  
          document.getElementById(controleRetorno).value = percentCalculado.replace(".", ",");

        if (document.getElementById(controleRetorno).value == 'NaN')
        {
            document.getElementById(controleRetorno).value = '0,00';
        }
        
        return document.getElementById(controleRetorno).value;
    }
