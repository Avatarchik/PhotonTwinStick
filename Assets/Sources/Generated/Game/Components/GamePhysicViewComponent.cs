//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PhysicViewComponent physicView { get { return (PhysicViewComponent)GetComponent(GameComponentsLookup.PhysicView); } }
    public bool hasPhysicView { get { return HasComponent(GameComponentsLookup.PhysicView); } }

    public void AddPhysicView(UnityEngine.Rigidbody newRigidbody) {
        var index = GameComponentsLookup.PhysicView;
        var component = CreateComponent<PhysicViewComponent>(index);
        component.rigidbody = newRigidbody;
        AddComponent(index, component);
    }

    public void ReplacePhysicView(UnityEngine.Rigidbody newRigidbody) {
        var index = GameComponentsLookup.PhysicView;
        var component = CreateComponent<PhysicViewComponent>(index);
        component.rigidbody = newRigidbody;
        ReplaceComponent(index, component);
    }

    public void RemovePhysicView() {
        RemoveComponent(GameComponentsLookup.PhysicView);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPhysicView;

    public static Entitas.IMatcher<GameEntity> PhysicView {
        get {
            if (_matcherPhysicView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PhysicView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPhysicView = matcher;
            }

            return _matcherPhysicView;
        }
    }
}
