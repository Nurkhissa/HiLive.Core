﻿using HiLive.API.Models.VideoMetadatas;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace HiLive.API.Brokers.Storoges
{
    public partial interface IStorageBroker
    {
        ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata);
        IQueryable<VideoMetadata> SelectAllVideoMetadatas();
        ValueTask<VideoMetadata> SelectVideoMetadataByIdAsync(Guid videoMetadataId);
        ValueTask<VideoMetadata> UpdateVideoMetadataAsync(VideoMetadata videoMetadata);
        ValueTask<VideoMetadata> DeleteVideoMetadataByIdAsync(Guid videoMetadataId);
    }
}
