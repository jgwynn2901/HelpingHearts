$(function () {
  var map;
  function initialize(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;
    // ReSharper disable UseOfImplicitGlobalInFunctionScope
    var coords = new google.maps.LatLng(latitude, longitude);

    var mapOptions = {
      zoom: 14,
      center: new google.maps.LatLng(position.coords.latitude, position.coords.longitude),
      mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map = new google.maps.Map(document.getElementById('map-canvas'),
      mapOptions);

    // ReSharper disable UnusedLocals
    var infowindow = new google.maps.InfoWindow({
      // ReSharper restore UnusedLocals
      map: map,
      position: coords,
      content: 'You are here!'
    });
  }
  function getLocation() {
    if (Modernizr.geolocation) {
      navigator.geolocation.getCurrentPosition(initialize, handleNoGeolocation, { timeout: 50000 });
    }
  }

  function handleNoGeolocation(errorFlag) {
    if (errorFlag) {
      alert('Error: The Geolocation service failed.');
    } else {
      alert('Error: Your browser doesn\'t support geolocation.');
    }
  }

  google.maps.event.addDomListener(window, 'load', getLocation);
  // ReSharper restore UseOfImplicitGlobalInFunctionScope

});