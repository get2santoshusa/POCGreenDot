var configService = (function () {
    var pocUrl = {
        postDeposit: 'http://localhost:63390/api/Transact/Deposite',
    };

    getUrl = function (strKey) {
        return pocUrl[strKey];
    };

    return {
        getUrl: getUrl
    };

})();