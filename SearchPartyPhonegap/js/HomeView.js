/**
 * Created with IntelliJ IDEA.
 * User: torbjornk
 * Date: 27.02.13
 * Time: 16:50
 * To change this template use File | Settings | File Templates.
 */
var HomeView = function() {

  this.render = function() {
    this.el.html(HomeView.template());
    return this;
  };

  this.initialize = function() {
    // Define a div wrapper for the view. The div wrapper is used to attach events.
    this.el = $('<div/>');
    this.el.on('click', '.button', this.taBilde);
  };

  this.taBilde = function() {

    event.preventDefault();
    if (!navigator.camera) {
      app.showAlert("Du ha'kke kamera din gjøk!", "Error");
      return;
    }
    var options =   {   quality: 50,
      destinationType: Camera.DestinationType.DATA_URL,
      sourceType: 1,      // 0:Photo Library, 1=Camera, 2=Saved Photo Album
      encodingType: 0,     // 0=JPG 1=PNG
      targetWidth: 1600,
      tagetHeight: 1200
    };

    navigator.camera.getPicture(
        function(imageData) {
          $('.bilde', this.el).attr('src', "data:image/jpeg;base64," + imageData);
        },
        function() {
          app.showAlert('Error taking picture', 'Error');
        },
        options);

    return false;
  };

  onPhotoURISuccess = function(imageURI) {
          var smallImage = document.getElementById('bilde');
          smallImage.style.display = 'block';

          // Show the captured photo.
          smallImage.src = imageURI;
      }

  this.initialize();

}

HomeView.template = Handlebars.compile($("#home-tpl").html());
