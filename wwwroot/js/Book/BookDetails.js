$(document).ready(function() {
  var discount = $("#discount").text().replace(',','.');
  if(discount)
  {
    var price = $("#prev-price").text().replace(',','.');
    $("#prev-price").html("$" + price);
    $("#discount").html((discount * 100) + "% discount");
    $("#discount-price").html("$" + (price * (1 - discount)));
  }
});