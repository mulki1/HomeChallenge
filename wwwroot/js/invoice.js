$("#btnAddInvoice").on("click", AddInvoice);
async function AddInvoice() {
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
        if (data.status) {
            $('#exampleModal').modal('toggle');
            swal({
                title: "Success!",
                text: data.message,
                icon: "success",
                button: "close",
            });
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
    let k = $('select[id=currency] option').filter(':selected').attr('exchangeRate');
    $("#exchangeRate").val(k)

})

$("#btnSearch").on("click", SearchInvoice);
async function SearchInvoice() {
   
    let invoiceDate = {
        date: $("#searchDate").val().trim(),
    }


    $.post("/Home/SearchInvoice", invoiceDate, function (data) {
        if (data.status) {
            table = $('#table_id').DataTable({
                destroy: true,
                data: data.invoice,
                columns: [
                    {
                        data: "CLientName",
                        render: function (data, d, row) {
                            return row.client.name;
                        }
                    },
                    {
                        data: "deliveryDate",
                        render: function (data) {
                            return data;
                        }
                    },
                    {
                        data: "amount",
                        render: function (data) {
                            return data;
                        }
                    },
                    {
                        data: "Currency",
                        render: function (data, d, row) {
                            return row.currency.name;
                        }
                    },
                    {
                        data: "Vat",
                        render: function (data, d, row) {
                            return row.vat.value;
                        }
                    },

                    {
                        data: "saleAgent",
                        render: function (data, d, row) {
                            return data;
                        }
                    },

                ]
            });

            if (data.invoice.length < 1) {
                toastr.error('No invoice for selected date', 'Error', {
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut",
                    timeOut: 3000
                });
            }

        } else {
            toastr.error('No invoice for selected date' , 'Error', {
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut",
                timeOut: 3000
            });
        }
    })


}