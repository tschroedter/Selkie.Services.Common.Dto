using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    public class PathDto
    {
        [NotNull]
        public PointDto EndPoint = new PointDto();

        public bool IsUnknown;

        [NotNull]
        public PolylineDto Polyline = new PolylineDto();

        [NotNull]
        public PointDto StartPoint = new PointDto();
    }
}