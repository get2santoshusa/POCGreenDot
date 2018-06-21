var indexPage = (function () {
    var indexPageObj = {};
    Init = function () {
        cacheDom();
        bindEvents();
    };

    cacheDom = function () {
        $el = $('#deposit');
        $txtFromAcc = $el.find('#txtFromAcc');
        $txtDestAcc = $el.find('#txtDestAcc');
        $txtAmount = $el.find('#txtAmount');
        $btnDeposite = $el.find('#btnDeposite');
    };

    bindEvents = function () {
        this.$btnDeposite.on('click', depositAmount.bind(this));
    };

    depositAmount = function () {
        $('#divLoading').show();
        var sendDepositeData = {
            FromAccount: this.$txtFromAcc.val().toUpperCase(),
            ToAccountNo: this.$txtDestAcc.val().toUpperCase(),
            Amount: this.$txtAmount.val()
        };

        var url = configService.getUrl("postDeposit");
        businessServices.callServicePost(sendDepositeData, url, null, null, function (data) {
            $('#divLoading').hide();
            $('#dialog').html(data.response);
            $('#saveModal').modal('show');
            
        });
    };
    Init();
})();