//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity mouseClickReleasedEntity { get { return GetGroup(InputMatcher.MouseClickReleased).GetSingleEntity(); } }

    public bool isMouseClickReleased {
        get { return mouseClickReleasedEntity != null; }
        set {
            var entity = mouseClickReleasedEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isMouseClickReleased = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly MouseClickReleasedComponent mouseClickReleasedComponent = new MouseClickReleasedComponent();

    public bool isMouseClickReleased {
        get { return HasComponent(InputComponentsLookup.MouseClickReleased); }
        set {
            if (value != isMouseClickReleased) {
                var index = InputComponentsLookup.MouseClickReleased;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseClickReleasedComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMouseClickReleased;

    public static Entitas.IMatcher<InputEntity> MouseClickReleased {
        get {
            if (_matcherMouseClickReleased == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseClickReleased);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseClickReleased = matcher;
            }

            return _matcherMouseClickReleased;
        }
    }
}
