﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;

namespace HiLive.API.Models.VideoMetadatas
{
    public class VideoMetadata
    {
        public Guid Id { get; set; } = new Guid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlobPath { get; set; }
        public string Thubnail { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
