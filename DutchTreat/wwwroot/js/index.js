﻿var x = 0;
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