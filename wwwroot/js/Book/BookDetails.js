$(document).ready(function() {
  var discount = $("#discount").text().replace(',','.');
  //discount = (",1").replace(',','.');
  if(discount)
  {
    var price = $("#prev-price").text().replace(',','.');
    $("#discount").html((discount * 100) + "% discount");
    $("#discount-price").html(price * (1 - discount));
  }
});