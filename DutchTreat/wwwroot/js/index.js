$(document).ready(function () {
	var x = 0;
	var s = "";
	var theForm = $("#theForm");
	theForm.hide();

	var button = $("#buyButton");
	button.on("click", function () {
		console.log("buying");
	});
	var productInfo = $(".products li");
	productInfo.on("click", function () {
		console.log("you clicked on " + $(this).text());
	}); 
	var $loginToggle = $("#loginToggle");
	var $popup = $(".popup");
	$loginToggle.on("click", function () {
		$popup.toggle(1000);
	});

});