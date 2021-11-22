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