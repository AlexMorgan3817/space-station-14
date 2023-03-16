using Content.Server.Explosion.EntitySystems;

namespace Content.Server.Explosion.Components
{
    /// <summary>
    /// Will add <see cref="GravityWellComponent"/> and enable to the attached entity upon a <see cref="TriggerEvent"/>.
    /// </summary>
    [RegisterComponent]
    public sealed class GravityWellOnTriggerComponent : Component
    {
        [DataField("removeOnTrigger")]
        public bool RemoveOnTrigger = false;

        [ViewVariables(VVAccess.ReadWrite)]
        [DataField("radialAcceleration")]
        public float RadialAcceleration = 1;

        [DataField("tangentialAcceleration")]
        [ViewVariables(VVAccess.ReadWrite)]
        public float TangentialAcceleration = 0.0f;
    }
}
