var RestView = function() {

	this.people = ["Yehuda Katz",
			       "Alan Johnson",
			       "Charles Jolley"
			      ]
	
	this.tweets = {"completed_in":0.05,"max_id":311911252739891200,"max_id_str":"311911252739891200","next_page":"?page=2&max_id=311911252739891200&q=mesan&rpp=2","page":1,"query":"mesan","refresh_url":"?since_id=311911252739891200&q=mesan","results":[{"created_at":"Wed, 13 Mar 2013 18:46:52 +0000","from_user":"AnaVanegs","from_user_id":762688717,"from_user_id_str":"762688717","from_user_name":"HERNAN CAMILO\u2665 *-*","geo":null,"id":311911252739891200,"id_str":"311911252739891200","iso_language_code":"es","metadata":{"result_type":"recent"},"profile_image_url":"http:\/\/a0.twimg.com\/profile_images\/3367964746\/476896a1c71814ef28e21b62cf12b979_normal.jpeg","profile_image_url_https":"https:\/\/si0.twimg.com\/profile_images\/3367964746\/476896a1c71814ef28e21b62cf12b979_normal.jpeg","source":"&lt;a href=&quot;http:\/\/twitter.com\/&quot;&gt;web&lt;\/a&gt;","text":"QUE SE MESAN EN EL COLUMPIO\u2665 \u266b\u266a"},{"created_at":"Wed, 13 Mar 2013 18:40:38 +0000","from_user":"tiaraNAMY","from_user_id":135411211,"from_user_id_str":"135411211","from_user_name":"ayaaaak","geo":null,"id":311909686746177536,"id_str":"311909686746177536","iso_language_code":"in","metadata":{"result_type":"recent"},"profile_image_url":"http:\/\/a0.twimg.com\/profile_images\/3354594674\/f369daa99091f82992c776e2a410f31e_normal.jpeg","profile_image_url_https":"https:\/\/si0.twimg.com\/profile_images\/3354594674\/f369daa99091f82992c776e2a410f31e_normal.jpeg","source":"&lt;a href=&quot;http:\/\/twitter.com\/&quot;&gt;web&lt;\/a&gt;","text":"omelete doang ngabaa. makanya tanya tadi. \"gratis?\" wkwkw ya sudahlah. udah ngawe diperut dia \"@arieakbar_88 Tp mesan RT @tiaraNAMY: nugget","to_user":"arieakbar_88","to_user_id":237113836,"to_user_id_str":"237113836","to_user_name":"Arie Akbar","in_reply_to_status_id":311908492464250881,"in_reply_to_status_id_str":"311908492464250881"}],"results_per_page":2,"since_id":0,"since_id_str":"0"}
	
	this.initialize = function() {
		// Define a div wrapper for the view. The div wrapper is used to attach events.
		this.el = $('<div/>');
	};
	
	this.getTweets = function() {
		var that = this;
	    var twurl = "http://search.twitter.com/search.json?q=mesan&rpp=10&callback=?";
	    
	    $.getJSON(twurl, function(data){
	    	$('.tweet-list').html(RestView.liTemplate({tweet: data}));
	    });
	}
	
	this.render = function() {
		this.getTweets();
		this.el.html(RestView.template());
		return this;
	}
	
	this.initialize();

}

RestView.template = Handlebars.compile($("#rest-tpl").html());
RestView.liTemplate = Handlebars.compile($("#rest-li-tpl").html());