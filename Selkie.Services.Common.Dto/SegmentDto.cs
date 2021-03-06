﻿using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class SegmentDto
    {
        [NotNull]
        public PointDto EndPoint = new PointDto();

        public bool IsUnknown;

        [NotNull]
        public PointDto StartPoint = new PointDto();

        [NotNull]
        public string Type = string.Empty;
    }
}