function initMap(_lat,_lng) {
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: _lat, lng: _lng },
        zoom: 18
    });
}