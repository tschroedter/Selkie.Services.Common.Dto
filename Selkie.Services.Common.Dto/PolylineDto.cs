using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class PolylineDto
    {
        [NotNull]
        public SegmentDto[] Segments = new SegmentDto[0];
    }
}