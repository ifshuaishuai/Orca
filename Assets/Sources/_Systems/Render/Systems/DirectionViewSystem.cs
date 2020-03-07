﻿using System;
using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class DirectionViewSystem : ReactiveSystem<GameEntity>
{
    private GameContext _gameContext;
    
    public DirectionViewSystem(Contexts contexts)
        : base(contexts.game)
    {
        _gameContext = contexts.game;
    }
    
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Direction.Added());
    }

    protected override bool Filter(GameEntity entity)
    {
        return  entity.hasView && entity.hasCharacter;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        for (int i = 0, length = entities.Count; i < length; ++i)
        {
            var e = entities[i];

            ChangeDirectionView(e);
            
            e.AddAnimatorState(e.state.state);
        }
    }

    private void ChangeDirectionView(GameEntity e)
    {
        var character = e.character.character;

        var config = _gameContext.config.animatorRunConfig.GetAnimatorRunConfig(character);

        var direction = e.direction.direction;
        var displaySprite = e.view.viewController.displaySprite;
        
        if (direction == CharacterDirection.Up || direction == CharacterDirection.Down)
        {
            // nothing
        }
        else
        {
            if (config.singleRun)
            {
                var scale = direction == CharacterDirection.Left
                    ? new Vector3(-1, 1, 1)
                    : new Vector3(1, 1, 1);

                displaySprite.scale = scale;
            }
            else
            {
                var scale = GetAnimatorScale(config, direction);
                displaySprite.scale = scale;
            }
        }
    }

    private Vector3 GetAnimatorScale(AnimatorRunConfig config, CharacterDirection direction)
    {
        switch (direction)
        {
            case CharacterDirection.Up:
                return config.scaleUp;
            
            case CharacterDirection.Right:
                return config.scaleRight;
            
            case CharacterDirection.Down:
                return config.scaleDown;
            
            case CharacterDirection.Left:
                return config.scaleLeft;
            
            default:
                throw new Exception("!!! Invalid direction");
        }
    }
}