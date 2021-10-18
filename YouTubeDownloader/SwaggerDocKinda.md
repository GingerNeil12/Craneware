# End Points

POST: /download

BODY:

```json
{
  "url": "URL GOES HERE",
  "includeMetaData": true,
  "clipVideo": true,
  "clipDetails": {
    "startTime": 12345,
    "endTime": 12456
  }
}
```

RESPONSE:

```json
{
  "fileLocation": "FILE LOCATION",
  "metaData": {
    "quality": "HIGH",
    "duration": 125678,
    "fileSize": "25mb",
    "channel": {
      "name": "CHANNEL NAME"
    }
  }
}
```
