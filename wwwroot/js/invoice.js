$("#btnAddInvoice").on("click", AddInvoice);
async function AddInvoice() {
    debugger;

    let invoice = {
        Amount: $("#amount").val().trim(),
        CurrencyId: $('select[id=currency] option').filter(':selected').val(),
        VatId: $('select[id=vat] option').filter(':selected').val(),
        ExchangeRateId: $("#exchangeRate").val().trim(),
        ClientId: $('select[id=client] option').filter(':selected').val(),
        OrderId: $("#orderNumber").val().trim(),
        InvoiceDate: $("#invoicedate").val().trim(),
        DeliveryDate: $("#deliverydate").val().trim(),
        SettleDate: $("#settledate").val().trim(),
        Description: $("#description").val().trim(),
        SaleAgent: $("#salesAgent").val().trim(),
    }


    $.post("/Home/AddInvoice", invoice, function (data) {
        debugger;
        if (data.status == "Success") {
            $('.new-user').modal('toggle');
            swal({
                title: "Success!",
                text: data.message,
                icon: "success",
                button: "close",
            });
            location.reload();
        } else {
            toastr.error(data.message, 'Error', {
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut",
                timeOut: 3000
            });
        }
    })


}

$("#currency").change(function () {

    debugger;
    let k = $('select[id=currency] option').filter(':selected').attr('exchangeRate');
    $("#exchangeRate").val(k) 
   
})

$("#btnSearch").on("click", SearchInvoice);
async function SearchInvoice() {
    debugger;

    let invoiceDate = {
        date: $("#searchDate").val().trim(),
    }


    $.post("/Home/SearchInvoice", invoiceDate, function (data) {
        debugger;
        if (data.status == "Success") {
            $('.new-user').modal('toggle');
            swal({
                title: "Success!",
                text: data.message,
                icon: "success",
                button: "close",
            });
            location.reload();
        } else {
            toastr.error(data.message, 'Error', {
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut",
                timeOut: 3000
            });
        }
    })


}