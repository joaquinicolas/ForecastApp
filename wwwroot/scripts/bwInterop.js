var bweInterop = {};

bweInterop.getPosition = async function () {
    function getPositionAsync() {
        return new Promise((success, err) => {
            navigator.geolocation
                .getCurrentPosition(success, err);
        });
    }

    if (navigator.geolocation) {
        let position = await getPositionAsync();
        return {
            latitude: position.coords.latitude,
            longitude: position.coords.longitude
        };
    } else {
        throw Error("Geolocation is not supported by this browser.");
    }
}