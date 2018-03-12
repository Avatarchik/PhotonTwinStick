//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly MarkForDeletionComponent markForDeletionComponent = new MarkForDeletionComponent();

    public bool isMarkForDeletion {
        get { return HasComponent(GameComponentsLookup.MarkForDeletion); }
        set {
            if (value != isMarkForDeletion) {
                var index = GameComponentsLookup.MarkForDeletion;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : markForDeletionComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherMarkForDeletion;

    public static Entitas.IMatcher<GameEntity> MarkForDeletion {
        get {
            if (_matcherMarkForDeletion == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MarkForDeletion);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMarkForDeletion = matcher;
            }

            return _matcherMarkForDeletion;
        }
    }
}
