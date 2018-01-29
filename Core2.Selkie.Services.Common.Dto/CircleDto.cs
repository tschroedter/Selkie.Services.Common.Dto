using JetBrains.Annotations;

namespace Core2.Selkie.Services.Common.Dto
{
    [UsedImplicitly]
    public class CircleDto
    {
        [NotNull]
        [UsedImplicitly]
        public PointDto CentrePoint = new PointDto();

        [UsedImplicitly]
        public bool IsUnknown;

        [UsedImplicitly]
        public double Radius;
    }
}