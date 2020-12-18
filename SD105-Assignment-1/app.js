function searchStreet(streetKey) {
    return fetch(`https://api.winnipegtransit.com/api/v3/stops/10064/schedule.json`);
    .then(resp => {
        console.log(resp);
    })
}

searchStreet(streetKey)