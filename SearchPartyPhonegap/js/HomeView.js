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
    this.el.on('click', '#taBilde', this.taBilde);
    this.el.on('click', '#lagreBilde', this.lagreBilde)
    this.hentBilder();
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
      encodingType: 0     // 0=JPG 1=PNG
    };

    navigator.camera.getPicture(
        function(imageData) {
          this.bilde = imageData;
          $('.bilde', this.el).attr('src', "data:image/jpeg;base64," + imageData);
        },
        function() {
          app.showAlert('Error taking picture', 'Error');
        },
        options);

    return false;
  };

  this.lagreBilde = function() {
    this.bilde = $('.bilde').prop('src');
    if (this.bilde == null) {
      app.showAlert('Du har ikke tatt noe bilde din gjøk!', 'Koko');
    } else {
      app.storage.lagreBilde(this.bilde, function (message) {
        alert(message);
      });
    }
  };

  this.hentBilder = function() {
    var bilder = app.storage.hentAlleBilder(function (bilder) {
      alert("Hentet " + bilder.rows.length + " bilder!");
      var bildeTabell = jQuery(".bilde");
      var tabellInnhold = "";
      for (var i = 0; i < bilder.length; i++)
      {
        if ((i % 4) == 0) {
          tabellInnhold = tabellInnhold + "<tr>";
        }
        tabellInnhold = tabellInnhold + "<td>";
        tabellInnhold = tabellInnhold + '<img class="thumbnail" src="data:image/jpeg;base64,"' + bilder[i].bilde + ' />';
        tabellInnhold = tabellInnhold + "</td>";

        if ((i % 4) == 0) {
          tabellInnhold = tabellInnhold + "</tr>";
        }
      }
    })
  }


  this.initialize();
}

HomeView.template = Handlebars.compile($("#home-tpl").html());
