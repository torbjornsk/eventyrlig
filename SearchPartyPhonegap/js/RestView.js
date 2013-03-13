var RestView = function() {

	this.people = ["Yehuda Katz",
			       "Alan Johnson",
			       "Charles Jolley"
			      ]
	
	this.initialize = function() {
		// Define a div wrapper for the view. The div wrapper is used to attach events.
		this.el = $('<div/>');
	};
	
	this.getTweets = function() {
	    var twurl = "http://search.twitter.com/search.json?q=mesan&rpp=1";
	    
	    $.getJSON(twurl, function(data){
	    	alert(data);
	        //$("#tmpl-tweets").tmpl(data.results).appendTo("#tweets");
	    });
	}
	
	this.render = function() {
		this.getTweets();
		this.el.html(RestView.template({people: this.people}));
		return this;
	}
	
	this.initialize();

}

RestView.template = Handlebars.compile($("#rest-tpl").html());