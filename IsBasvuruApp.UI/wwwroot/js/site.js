// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$('#IlID').on('change', function () {
    var myUrl = '/Home/IlceleriGetir/';

    $.ajax({
        url: myUrl,
        type: "GET",
        data: { id: $(this).val()},
        success: function (response) {
            $('#IlceID').empty();
            response.forEach(a => {
                $('#IlceID').append(new Option(`${a.adi}`, `${a.id}`));
            })
        }
    })
});