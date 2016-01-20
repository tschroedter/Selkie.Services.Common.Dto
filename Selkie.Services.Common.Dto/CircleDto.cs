using JetBrains.Annotations;

namespace Selkie.Services.Common.Dto
{
    public class CircleDto
    {
        [NotNull]
        public PointDto CentrePoint = new PointDto();

        public bool IsUnknown;
        public double Radius;
    }
}