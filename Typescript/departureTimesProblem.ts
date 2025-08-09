const departureTimes = ['17:15', '12:30', '14:00', '08:15', '00:00', '14:15'];
const currentTime = '14:30';

let latestDepartureTime = 0;

const getLatestDepartureElapsedTimeInMins = (times: string[], currentTime: string): number => {
  let convertedCurrentTime = parseInt(currentTime.replace(':', ''));
  console.log(`convertedCurrentTime: ${convertedCurrentTime}`);

  for(let i = 0; i < departureTimes.length; i++) {
    let convertedDepartureTime = parseInt(departureTimes[i].replace(':', ''));

    if (convertedDepartureTime <= convertedCurrentTime && convertedDepartureTime > latestDepartureTime) {
      latestDepartureTime = convertedDepartureTime;
      console.log(`latestDepartureTime is now: ${latestDepartureTime}`);
    }
  }

  let hoursDiff = parseInt(convertedCurrentTime.toString().slice(0,2)) - parseInt(latestDepartureTime.toString().slice(0,2));
  let minsDiff = parseInt(convertedCurrentTime.toString().slice(2,4)) - parseInt(latestDepartureTime.toString().slice(2,4));
  console.log(`current time hours: ${parseInt(convertedCurrentTime.toString().slice(0,2))}`);
  console.log(`current time minutes: ${parseInt(convertedCurrentTime.toString().slice(2,4))}`);
  console.log(`latest departure time hours: ${parseInt(latestDepartureTime.toString().slice(0,2))}`);
  console.log(`latest departure time minutes: ${parseInt(latestDepartureTime.toString().slice(2,4))}`);
  
  console.log(`hours diff from latest departure time: ${hoursDiff}`);
  console.log(`mins diff from latest departure time: ${minsDiff}`);

  return latestDepartureTime == 0 ? -1 : (hoursDiff * 60) + minsDiff;
}

console.log(`latest departure elapsed time: ${getLatestDepartureElapsedTimeInMins(departureTimes, currentTime)}`);