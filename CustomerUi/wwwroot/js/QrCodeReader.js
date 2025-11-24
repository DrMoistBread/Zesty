let html5QrCode;

window.qrScanner = {
    start: function (dotNetObjRef) {
        html5QrCode = new Html5Qrcode("reader");
        html5QrCode.start(
            { facingMode: "environment" },
            { fps: 10, qrbox: 250 },
            qrCodeMessage => {
                console.log("QR Code detected:", qrCodeMessage);
                dotNetObjRef.invokeMethodAsync("OnQrScanned", qrCodeMessage);

                // 👇 Auto-stop after first successful scan
                html5QrCode.stop()
                    .then(() => {
                        console.log("Scanner stopped after successful scan");
                        html5QrCode.clear(); // remove video preview
                    })
                    .catch(err => console.error("Error stopping scanner:", err));
            },
            errorMessage => {
                console.log("Scanning error:", errorMessage);
            }
        );
    },

    stop: function () {
        if (html5QrCode) {
            html5QrCode.stop()
                .then(() => {
                    console.log("Scanner stopped manually");
                    html5QrCode.clear();
                })
                .catch(err => console.error("Error stopping scanner:", err));
        }
    }
};
