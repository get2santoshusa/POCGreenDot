var businessServices = (function () {

    var commonService = {};
    
    commonService.callServicePost = function (request, url, msgTarget, originUrl, callback) {

        jQuery.support.cors = true;

        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(request),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            crossDomain: true,
            success: function (data) {
                callback(data);
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                if (xmlHttpRequest.status == 401) {
                    //log the error session expired
                    alert('Session Expired');
                    return;
                }
                //log the error message -- Unable to retrieve record.
                alert('(Ajax error: ' + xmlHttpRequest.status + ')');
                alert(xmlHttpRequest.responseText);
            }
        });

    };

    return commonService;



})();