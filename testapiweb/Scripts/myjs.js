function Send() {
    jQuery(document).ready(function ($) {
  
        var url = "/Countries/Getinfo";
        var countryname = $("#txtcountry").val();
 
        $.ajax({
            url: url,
            data: { countryname },
            cache: false,
            type: "POST"
        });
    });
}
