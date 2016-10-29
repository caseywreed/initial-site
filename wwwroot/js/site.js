// Write your Javascript code.
$(document).ready(function () {
  $("#ChosenUser_UserId").on("change", function () {
    $.ajax({
      url: `/User/Activate/${$(this).val()}`,
      method: "POST",
      dataType: "json",
      contentType: 'application/json; charset=utf-8'
    }).done(()=> {
        location.replace("/");
    });
  });

  $("#NewProduct_ProductTypeId").on("change", function () {

    $.ajax({
      url: `/Products/GetSubTypes/${$(this).val()}`,
      method: "POST",
      dataType: "json",
      contentType: 'application/json; charset=utf-8'
    }).done((data)=> {
      var subProductTypes = data;
      console.log(subProductTypes);
    });
  });
});