window.clientHandler = {
    startVideo: function (elementRef) {
        if (navigator.mediaDevices.getUserMedia) {
            navigator.mediaDevices.getUserMedia({ video: true })
                .then(function (stream) {
                    elementRef.srcObject = stream;
                })
                .catch(function (error) {
                    console.log("Something went wrong!", error);
                });
        }
    },
    playVideo: function (video, stream) {
        video.play();
    }
}

