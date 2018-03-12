//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputContext {

    public InputEntity mouseClickStayEntity { get { return GetGroup(InputMatcher.MouseClickStay).GetSingleEntity(); } }

    public bool isMouseClickStay {
        get { return mouseClickStayEntity != null; }
        set {
            var entity = mouseClickStayEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isMouseClickStay = true;
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

    static readonly MouseClickStayComponent mouseClickStayComponent = new MouseClickStayComponent();

    public bool isMouseClickStay {
        get { return HasComponent(InputComponentsLookup.MouseClickStay); }
        set {
            if (value != isMouseClickStay) {
                var index = InputComponentsLookup.MouseClickStay;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : mouseClickStayComponent;

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

    static Entitas.IMatcher<InputEntity> _matcherMouseClickStay;

    public static Entitas.IMatcher<InputEntity> MouseClickStay {
        get {
            if (_matcherMouseClickStay == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MouseClickStay);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMouseClickStay = matcher;
            }

            return _matcherMouseClickStay;
        }
    }
}
