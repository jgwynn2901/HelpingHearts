
var mapInfo = {
  map: {},
  initialize: function (position) {
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
 
    setTimeout(setLocation(this.map, coords), 100);
    setTimeout(getData(this.map), 1000);

  },

  getLocation: function () {
    if (Modernizr.geolocation) {
      navigator.geolocation.getCurrentPosition(this.initialize, this.handleNoGeolocation, { timeout: 50000 });
    }
  },

  handleNoGeolocation: function (errorFlag) {
    if (errorFlag) {
      alert('Error: The Geolocation service failed.');
    } else {
      alert('Error: Your browser doesn\'t support geolocation.');
    }
  },
};

function setLocation(map, coords)
{
  // ReSharper disable UnusedLocals
  var infowindow = new google.maps.InfoWindow({
    map: map,
    position: coords,
    content: "You are here!"
  });
}
function getData(map) {
  var uri = window.location.protocol + '//' + window.location.host + '/api/aed';
// Send an AJAX request
  $.getJSON(uri)
    .done(function(data) {
      // On success, 'data' contains a list of products.
      $.each(data, function(key, item) {
        // Add a list item for the product.
        createMarker(item);
      });
    });
}

function createMarker(item) {
  var marker = new google.maps.Marker({
    position: new google.maps.LatLng(item.Latitude, item.Longitude),
    title: item.Address,
    note: "<b>" + item.Name + "</b><br/>" + item.Address,
    map: map
  });
  marker['infowindow'] = new google.maps.InfoWindow({
    content: marker.note
  });
  google.maps.event.addListener(marker, 'click', function () {
    this['infowindow'].open(this.getMap(), this);
  });

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

