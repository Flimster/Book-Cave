$(document).ready(function() {
  var price = $("#prev-price").text();
  if(price)
  {
    //var discount = $("#discount").text();
    var discount = .9;
    price =  (+price.replace(',','.') *discount);
    $("#discount-price").html(price);
  }
});
