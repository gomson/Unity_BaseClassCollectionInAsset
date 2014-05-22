Unity_BaseClassCollectionInAsset
================================

An example of how to get Unity to serialize a collection of a base class, but have the inspector display the concrete class of each item

Consider the scenario:

  public class Question  { }
  public class MultipleChoiceQuestion : Question { }
  public class TrueFalseQuestion : Question { }
  
  public class QuizData
  {
    List<Question> questions;
  }

by default, when inspected, "questions" will display all elements of the collection as Question. If an item is actually a MultipleChoiceQuestion, you will not be able to see the fields within it. This project is an example of how to work around this limitation.

Essentially, one must:
* Create a custom Editor for QuizData
* Override OnInspectorGUI and call DrawPropertiesExcluding(serializedObject, "questions")
* Get the SerializedProperty for "questions"
* Iterate over properties for each element in the array
* Create and Editor for each element (Editor drawer = Editor.CreateEditor(item))
* Call the created Editor's OnInspectorGUI method (drawer.OnInspectorGUI())

I've gone a few steps further and made all classes ScriptableObjects, stored all data in a .asset file, and implemented a rudimentary collection Editor for adding and removing Questions.
