
var mapInfo = {
  map: {},
  initialize: function(position) {
    var latitude = position.coords.latitude;
    var longitude = position.coords.longitude;
    // ReSharper disable UseOfImplicitGlobalInFunctionScope
    var coords = new google.maps.LatLng(latitude, longitude);
    
    var mapOptions = {
      zoom: 16,
      center: new google.maps.LatLng(latitude, longitude),
      mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var $content = $("div:jqmData(role=content)");
    $content.height(getRealContentHeight());
    this.map = new google.maps.Map(document.getElementById('map-canvas'),
      mapOptions);
    
    // ReSharper disable UnusedLocals
    var infowindow = new google.maps.InfoWindow({
      map: this.map,
      position: coords,
      content: "You are here!"
    });
  },

  getLocation: function() {
    if (Modernizr.geolocation) {
      navigator.geolocation.getCurrentPosition(this.initialize, this.handleNoGeolocation, { timeout: 50000 });
    }
  },

  handleNoGeolocation: function(errorFlag) {
    if (errorFlag) {
      alert('Error: The Geolocation service failed.');
    } else {
      alert('Error: Your browser doesn\'t support geolocation.');
    }
  }
};

function addMarker(address) {
  var marker = new google.maps.Marker({
    position: new google.maps.LatLng(address.lat, address.lon),
    title: address.address
  });
  marker.setMap(mapInfo.map);
};

// ReSharper restore UseOfImplicitGlobalInFunctionScope
function getRealContentHeight() {
  var header = $.mobile.activePage.find("div[data-role='header']:visible");
  var footer = $.mobile.activePage.find("div[data-role='footer']:visible");
  var content = $.mobile.activePage.find("div[data-role='content']:visible:visible");
  var viewportHeight = $(window).height();

  var contentHeight = viewportHeight - header.outerHeight() - footer.outerHeight();
  if ((content.outerHeight() - header.outerHeight() - footer.outerHeight()) <= viewportHeight) {
    contentHeight -= (content.outerHeight() - content.height());
  }
  return contentHeight;
};

