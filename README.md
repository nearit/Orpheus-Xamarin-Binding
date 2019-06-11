This Visual Studio solution is used to bind the Orpheus (jsonApi parser) library.

Binding an Android Library means taking an aar (with a Java interface) and create a DDL (with a C# interface) to be used in other projects. Specifically, this DDL will be used in the project to create the binding for the NearIT Android SDK.

For the current version of this binding no custom configuration in Transforms files was needed.
This project has 1 dependency, Gson. Gson will NOT be bundled in the resulting dll for this project.
Whenever using this dll, one should also include the Gson dll for the 8.5.0 version, luckily the Gson binding (for that version) can be found on nuget.
When using the NearIT Xamarin Bridge, all dlls are automatically included.