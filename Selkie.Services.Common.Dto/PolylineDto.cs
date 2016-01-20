using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    public class PolylineDto
    {
        [NotNull]
        public SegmentDto[] Segments = new SegmentDto[0];
    }
}