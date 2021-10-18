# Use Case 1

- **Name**: Download Video
- **Actor**: Anonymous User
- **Pre Conditions**: Video hasn't been requested before.
- **Constraints**: No Other meta data is being requested IE Quality etc
- **Basic Flow**:
  1. User Submits YouTube URL
  2. The URL is parsed and the Video ID (VID) is extracted
  3. Video is downloaded from YouTube via nuget package
  4. The video is stored in a File Server
  5. The VID is used as an ID for the cache and the location of the video is stored along with it.
  6. Results returned to the User

# Use Case 2

- **Name**: Download Video (with meta data)
- **Actor**: Anonymous User
- **Pre Conditions**: Video may have been requested before.
- **Basic Flow**:
  1. User Submits YouTube URL
  2. The URL is parsed and the Video ID (VID) is extracted
  3. The cache is checked for the VID
     1. If found then the video and associated information is returned to the User.
  4. Video is downloaded from YouTube via nuget package
  5. The video is stored in a File Server
  6. The assoicated information (Quality, duration, file location) are stored in a DB
  7. The VID is used as an ID for the cache which will point to the relevant entry in the DB.
  8. Results returned to the User

# Use Case 3

- **Name**: Download and Clip Data
- **Actor**: Anonymous User
- **Pre Conditions**: Video may have been requested before.
- **Basic Flow**:
  1. User Submits YouTube URL and Start and End times of requested the clip
  2. The URL is parsed and the Video ID (VID) is extracted
  3. The cache is checked for the VID
     1. If the VID exists then the video is loaded from the File Server
        (skip to 8)
  4. Video is downloaded from YouTube via nuget package
  5. Video is stored in a File Server
  6. The assoicated information (Quality, duration, file location) are stored in a DB
  7. The VID is used as an ID for the cache which will point to the relevant entry in the DB.
  8. The video location and clipping times passed to a Clipping Service
  9. Clipping service processes the video and clips using 3rd party nuget library
  10. Clip is registered as a child entity on the main video record of the DB
  11. Clip is returned to the User
