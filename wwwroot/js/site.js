function setupIcons() {
  const lightSchemeIcon = document.querySelector('link#icono-claro');
  const darkSchemeIcon = document.querySelector('link#icono-oscuro');
  
  function setLight() {
    document.head.append(lightSchemeIcon);
    darkSchemeIcon.remove();
  }

  function setDark() {
    lightSchemeIcon.remove();
    document.head.append(darkSchemeIcon);
  }


  const matcher = window.matchMedia('(prefers-color-scheme:dark)');
  function onUpdate() {
    if (matcher.matches) {
      setDark();
    } else {
      setLight();
    }
  }
  matcher.addListener(onUpdate);
  onUpdate();
}
  
setupIcons();

/* Scroll hacia arriba */
$(document).ready(function(){
  $(window).scroll(function () {
         if ($(this).scrollTop() > 50) {
             $('#subir').fadeIn();
         } else {
             $('#subir').fadeOut();
         }
     });
     // scroll body to 0px on click
     $('#subir').click(function () {
         $('#subir').tooltip('hide');
         $('body,html').animate({
             scrollTop: 0
         }, 800);
         return false;
     });
     
     $('#subir').tooltip('show');

});

const getCookieValue = (name) => (
  document.cookie.match('(^|;)\\s*' + name + '\\s*=\\s*([^;]+)')?.pop() || ''
)

function modoOscuro() {
  var checkBox = document.getElementById("modoOscuro-checkbox");
  let cookieOscuro = getCookieValue("modoOscuro");
  if ((cookieOscuro == "true") || (cookieOscuro == "false")){
    if (cookieOscuro == "true") {
      checkBox.defaultChecked = true;
      document.documentElement.style.setProperty('--Fuente', '#EEE');
      document.documentElement.style.setProperty('--Fondo', '#1F2123');
      document.documentElement.style.setProperty('--Card', '#343A40');
      document.documentElement.style.setProperty('--Boton', '#F8F9FA');
      document.documentElement.style.setProperty('--Borde', 'rgba(255,255,255,.15');
      if (!checkBox.checked) {
        document.cookie = "modoOscuro=false; path=/";
        modoOscuro();
      }
    }
    else if (cookieOscuro == "false") {
      checkBox.defaultChecked = false;
      document.documentElement.style.setProperty('--Fuente', '#000');
      document.documentElement.style.setProperty('--Fondo', '#F9F9F9');
      document.documentElement.style.setProperty('--Card', '#F8F9FA');
      document.documentElement.style.setProperty('--Boton', '#343A40');
      document.documentElement.style.setProperty('--Borde', 'rgba(0,0,0,.15');
      if (checkBox.checked) {
        document.cookie = "modoOscuro=true; path=/";
        modoOscuro();
      }
    }
  }
  else {
    if (checkBox.checked == true){
      document.cookie = "modoOscuro=true; path=/";
      document.documentElement.style.setProperty('--Fuente', '#EEE');
      document.documentElement.style.setProperty('--Fondo', '#1F2123');
      document.documentElement.style.setProperty('--Card', '#343A40');
      document.documentElement.style.setProperty('--Boton', '#F8F9FA');
      document.documentElement.style.setProperty('--Borde', 'rgba(255,255,255,.15');
    } else {
      document.cookie = "modoOscuro=false; path=/";
      document.documentElement.style.setProperty('--Fuente', '#000');
      document.documentElement.style.setProperty('--Fondo', '#F9F9F9');
      document.documentElement.style.setProperty('--Card', '#F8F9FA');
      document.documentElement.style.setProperty('--Boton', '#343A40');
      document.documentElement.style.setProperty('--Borde', 'rgba(0,0,0,.15');
    }
  }
  
}

window.onload = function() {
  modoOscuro();
}