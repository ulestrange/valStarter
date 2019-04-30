$("#studentdropdown").on('change', function () {
    studentid = $(this).children("option:selected").val();
    $.ajax({
        url: '/data/display/' + studentid,
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (data) {
            $('#firstname').html(data.firstName);
            $('#lastname').html(data.lastName);
            
        }
     
    });
  
});