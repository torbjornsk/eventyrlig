var RestView = function() {

	this.people: ["Yehuda Katz",
			      "Alan Johnson",
			      "Charles Jolley"
			     ]
	
	this.initialize = function() {
		// Define a div wrapper for the view. The div wrapper is used to attach events.
		this.el = $('<div/>');
	};
	
	this.render = function() {
		this.el.html(RestView.template());
		return this;
	}
	
	this.initialize();

}

RestView.template = Handlebars.compile($("#rest-tpl").html());