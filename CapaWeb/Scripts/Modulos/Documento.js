var EMD = EMD || {};
EMD.Documento = (function () {

    var init = function (xml) {
        $.ajax({
            type: "POST",
            url: "/Documento/listaCliente",
            data: JSON.stringify({ xml: xml }),
            data: '',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {



                $.each(data, function (key, val) {
                     var tr = $('<tr>');
                     tr.html('<td>' + val.id + '</td>' +
                         '<td>' + val.nombre + '</td>' +
                         '<td>' + val.tipoDocumento + '</td>' +
                         '<td>' + val.numDoc + '</td>' +
                         '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var agregar = function (nombre, tipo, numero) {
        $('#listaCliente').html('');
        $.ajax({
            type: "POST",
            url: "/Documento/agregarCliente",
            data: JSON.stringify({nombre:nombre,tipo:tipo,numero:numero}),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {



                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipoDocumento + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };
    var buscar = function (numero) {
        $('#listaCliente').html('');
        $.ajax({
            type: "POST",
            url: "/Documento/buscarCliente",
            data: JSON.stringify({numero: numero }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {



                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipoDocumento + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var eliminar = function (numero) {
        $('#listaCliente').html('');
        $.ajax({
            type: "POST",
            url: "/Documento/eliminarCliente",
            data: JSON.stringify({ numero: numero }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {



                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipoDocumento + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var actualizar = function (nombre, tipo, numero) {
        $('#listaCliente').html('');
        $.ajax({
            type: "POST",
            url: "/Documento/actualizaCliente",
            data: JSON.stringify({ nombre: nombre, tipo: tipo, numero: numero }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {



                $.each(data, function (key, val) {
                    var tr = $('<tr>');
                    tr.html('<td>' + val.id + '</td>' +
                        '<td>' + val.nombre + '</td>' +
                        '<td>' + val.tipoDocumento + '</td>' +
                        '<td>' + val.numDoc + '</td>' +
                        '<td>' + val.activo + '</td>');
                    $('#listaCliente').append(tr);
                    //$('#txtCliente').val(val.cliente);
                });
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };

    var reporte = function () {
        
        $.ajax({
            type: "POST",
            url: "/Documento/reporteCliente",
            //url: "/Reportes/CrytalReport.aspx/LoadReport",
            //data: JSON.stringify({ nombre: nombre, tipo: tipo, numero: numero }),
            data: JSON.stringify({ xml: 're' }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                window.open('http://localhost:53097/Reportes/CrytalReport.aspx', '_newtab');
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    };


    return {
        init: init,
        agregar: agregar,
        buscar: buscar,
        eliminar: eliminar,
        actualizar: actualizar,
        reporte:reporte
    }
})();