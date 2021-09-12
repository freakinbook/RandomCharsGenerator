# RandomCharsGenerator

This project was my homework on dependency injection.

Here we have several generators implementing IGenerator interface and several writers implementing IWriter interface.

The two generators are similar. One is using an array of chars and the other is appending strings.

As for writers: one is used to output generated text to console and the other to a file.

Which generator or writer to use is resolved using unity container.
