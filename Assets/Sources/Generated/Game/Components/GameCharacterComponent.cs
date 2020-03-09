//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public CharacterComponent character { get { return (CharacterComponent)GetComponent(GameComponentsLookup.Character); } }
    public bool hasCharacter { get { return HasComponent(GameComponentsLookup.Character); } }

    public void AddCharacter(Character newCharacter) {
        var index = GameComponentsLookup.Character;
        var component = (CharacterComponent)CreateComponent(index, typeof(CharacterComponent));
        component.character = newCharacter;
        AddComponent(index, component);
    }

    public void ReplaceCharacter(Character newCharacter) {
        var index = GameComponentsLookup.Character;
        var component = (CharacterComponent)CreateComponent(index, typeof(CharacterComponent));
        component.character = newCharacter;
        ReplaceComponent(index, component);
    }

    public void RemoveCharacter() {
        RemoveComponent(GameComponentsLookup.Character);
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

    static Entitas.IMatcher<GameEntity> _matcherCharacter;

    public static Entitas.IMatcher<GameEntity> Character {
        get {
            if (_matcherCharacter == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Character);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacter = matcher;
            }

            return _matcherCharacter;
        }
    }
}
