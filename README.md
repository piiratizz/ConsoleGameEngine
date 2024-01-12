This is simple open source console game engine.
You can create your own game in console easily.

Get started.

Create first game.

1. Step 1: First you need to create Gameplay initializator, you can call it as you want but you need
   to set attribute **[GameplayInitializator]** and implement IGameplayInitializator interface.
    In Start method you will create instance of in game objects.
   
2. Step 2: Now you need to select will be your object renderer or no.
   If your object dont need to be rendered you need to implement MonoBehaviour
   If will be rendered you need to implement MonoBehaviourRendererDecorator.

3. Step 3: Now you have 2 methods Update and Start
   Start will be run once when game was started.
   Update will be run every frame.

4. Read docs for detail.
