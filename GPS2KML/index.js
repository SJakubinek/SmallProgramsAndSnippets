const ExifReader = require("exifreader");
const fs = require("fs");

let i = 1;
let coordinates = [];

exif();
async function exif() {
  const exifErrors = ExifReader.errors;

  const directoryPath = "./photos/";
  const kmlFileName = "20240513.kml";
  let kmlData =
    '<?xml version="1.0" encoding="UTF-8"?>\n<kml xmlns="http://www.opengis.net/kml/2.2">\n<Document>\n<name>Photo Route</name>\n<Style id="BlueLine">\n<LineStyle>\n<color>00FF7F3A</color>\n<width>4</width>\n</LineStyle>\n<PolyStyle>\n<color>00FF7F3A</color>\n</PolyStyle>\n</Style>\n';
  let pointCoords = "";

  const files = fs.readdirSync(directoryPath);
  for (const file of files) {
    const tags = await ExifReader.load(directoryPath + file, {
      expanded: true,
    });
    // Removing everything instead of GPS data
    if (tags.exif) {
      delete tags.exif["MakerNote"];
      delete tags["Thumbnail"];
      delete tags["mpf"];
      delete tags["file"];
      delete tags.exif["ImageWidth"];
      delete tags.exif["ImageLength"];
      delete tags.exif["Make"];
      delete tags.exif["Model"];
      delete tags.exif["Orientation"];
      delete tags.exif["XResolution"];
      delete tags.exif["YResolution"];
      delete tags.exif["ResolutionUnit"];
      delete tags.exif["DateTime"];
      delete tags.exif["YCbCrPositioning"];
      delete tags.exif["Exif IFD Pointer"];
      delete tags.exif["GPS Info IFD Pointer"];
      delete tags.exif["ExposureTime"];
      delete tags.exif["FNumber"];
      delete tags.exif["ISOSpeedRatings"];
      delete tags.exif["ExifVersion"];
      delete tags.exif["DateTimeOriginal"];
      delete tags.exif["DateTimeDigitized"];
      delete tags.exif["OffsetTime"];
      delete tags.exif["OffsetTimeOriginal"];
      delete tags.exif["ComponentsConfiguration"];
      delete tags.exif["ShutterSpeedValue"];
      delete tags.exif["ApertureValue"];
      delete tags.exif["ExposureBiasValue"];
      delete tags.exif["MaxApertureValue"];
      delete tags.exif["LightSource"];
      delete tags.exif["Flash"];
      delete tags.exif["FocalLength"];
      delete tags.exif["SubSecTime"];
      delete tags.exif["SubSecTimeOriginal"];
      delete tags.exif["SubSecTimeDigitized"];
      delete tags.exif["FlashpixVersion"];
      delete tags.exif["ColorSpace"];
      delete tags.exif["PixelXDimension"];
      delete tags.exif["PixelYDimension"];
      delete tags.exif["Interoperability IFD Pointer"];
      delete tags.exif["SensingMethod"];
      delete tags.exif["WhiteBalance"];
      delete tags.exif["DigitalZoomRatio"];
      delete tags.exif["FocalLengthIn35mmFilm"];
      delete tags.exif["GPSLatitudeRef"];
      delete tags.exif["GPSLatitude"];
      delete tags.exif["GPSLongitudeRef"];
      delete tags.exif["GPSLongitude"];
      delete tags.exif["GPSAltitudeRef"];
      delete tags.exif["GPSAltitude"];
      delete tags.exif["GPSTimeStamp"];
      delete tags.exif["GPSProcessingMethod"];
      delete tags.exif["GPSDateStamp"];
      delete tags.exif["InteroperabilityIndex"];
      delete tags.exif["InteroperabilityVersion"];
    }

    pointCoords += await listTags(tags);
    i++;
  }

  kmlData +=
    "<Placemark>\n<name>Route</name>\n<visibility>1</visibility>\n<styleUrl>#BlueLine</styleUrl>\n<LineString>\n<tessellate>1</tessellate>\n<altitudeMode>absolute</altitudeMode>\n<coordinates>\n";
  for (let i = 0; i < coordinates.length; i++) {
    kmlData += coordinates[i] + "\n";
  }
  kmlData += "</coordinates>\n</LineString>\n</Placemark>\n";

  kmlData += pointCoords + "</Document>\n</kml>\n";

  fs.writeFile(kmlFileName, kmlData, (err) => {
    if (err) {
      console.error(err);
    } else {
      // file written successfully
    }
  });
}

async function listTags(tags) {
  let data = "<Placemark>\n<name>" + i + "</name>\n<Point>\n<coordinates>\n";
  let longitude;
  let latitude;
  let altitude;
  let coor = [];
  for (const group in tags) {
    for (const name in tags[group]) {
      if (group === "gps" && name === "Longitude") {
        longitude = tags[group][name];
        console.log(`${group}:${name}: ${tags[group][name]}`);
      } else if (group === "gps" && name === "Latitude") {
        latitude = tags[group][name];
        console.log(`${group}:${name}: ${tags[group][name]}`);
      } else if (group === "gps" && name === "Altitude") {
        altitude = tags[group][name];
        console.log(`${group}:${name}: ${tags[group][name]}`);
      }
    }
  }
  coor[0] = longitude;
  coor[1] = latitude;
  coor[2] = altitude;
  coordinates[i - 1] = coor;
  data +=
    longitude +
    "," +
    latitude +
    "," +
    altitude +
    "\n</coordinates>\n</Point>\n</Placemark>\n";
  return data;
}
