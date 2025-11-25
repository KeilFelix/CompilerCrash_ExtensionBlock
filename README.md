This repository showcases a Compiler crash with the new extension block feature.

This is the crash:
Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
   at Microsoft.Cci.MetadataWriter.CheckNameLength(String name, INamedEntity errorEntity)
   at Microsoft.Cci.MetadataWriter.PopulateFieldTableRows()
   at Microsoft.Cci.MetadataWriter.PopulateTypeSystemTables(Int32[] methodBodyOffsets, PooledBlobBuilder& mappedFieldDataWriter, PooledBlobBuilder& resourceWriter, BlobBuilder dynamicAnalysisData, Blob& mvidFixup)
   at Microsoft.Cci.MetadataWriter.BuildMetadataAndIL(PdbWriter nativePdbWriterOpt, BlobBuilder ilBuilder, PooledBlobBuilder& mappedFieldDataBuilder, PooledBlobBuilder& managedResourceDataBuilder, Blob& mvidFixup, Blob& mvidStringFixup)
   at Microsoft.Cci.PeWriter.WritePeToStream(EmitContext context, CommonMessageProvider messageProvider, Func`1 getPeStream, Func`1 getPortablePdbStreamOpt, PdbWriter nativePdbWriterOpt, String pdbPathOpt, Boolean metadataOnly, Boolean isDeterministic, Boolean emitTestCoverageData, Nullable`1 privateKeyOpt, CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.Compilation.SerializePeToStream(CommonPEModuleBuilder moduleBeingBuilt, DiagnosticBag metadataDiagnostics, CommonMessageProvider messageProvider, Func`1 getPeStream, Func`1 getMetadataPeStreamOpt, Func`1 getPortablePdbStreamOpt, PdbWriter nativePdbWriterOpt, String pdbPathOpt, RebuildData rebuildData, Boolean metadataOnly, Boolean includePrivateMembers, Boolean isDeterministic, Boolean emitTestCoverageData, Nullable`1 privateKeyOpt, CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.Compilation.SerializeToPeStream(CommonPEModuleBuilder moduleBeingBuilt, EmitStreamProvider peStreamProvider, EmitStreamProvider metadataPEStreamProvider, EmitStreamProvider pdbStreamProvider, RebuildData rebuildData, Func`2 testSymWriterFactory, DiagnosticBag diagnostics, EmitOptions emitOptions, Nullable`1 privateKeyOpt, CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.CommonCompiler.CompileAndEmit(TouchedFileLogger touchedFilesLogger, Compilation& compilation, ImmutableArray`1 analyzers, ImmutableArray`1 generators, ImmutableArray`1 additionalTextFiles, AnalyzerConfigSet analyzerConfigSet, ImmutableArray`1 sourceFileAnalyzerConfigOptions, ImmutableArray`1 embeddedTexts, DiagnosticBag diagnostics, ErrorLogger errorLogger, CancellationToken cancellationToken, CancellationTokenSource& analyzerCts, AnalyzerDriver& analyzerDriver, Nullable`1& generatorTimingInfo)
   at Microsoft.CodeAnalysis.CommonCompiler.RunCore(TextWriter consoleOutput, ErrorLogger errorLogger, CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.CommonCompiler.Run(TextWriter consoleOutput, CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.CSharp.CommandLine.Csc.<>c__DisplayClass1_0.<Run>b__0(TextWriter tw)
   at Microsoft.CodeAnalysis.CommandLine.ConsoleUtil.RunWithUtf8Output[T](Func`2 func)
   at Microsoft.CodeAnalysis.CSharp.CommandLine.Csc.Run(String[] args, BuildPaths buildPaths, TextWriter textWriter, IAnalyzerAssemblyLoader analyzerLoader)
   at Microsoft.CodeAnalysis.CommandLine.BuildClient.RunLocalCompilation(String[] arguments, BuildPaths buildPaths, TextWriter textWriter)
   at Microsoft.CodeAnalysis.CommandLine.BuildClient.RunCompilation(IEnumerable`1 originalArguments, BuildPaths buildPaths, TextWriter textWriter, String pipeName)
   at Microsoft.CodeAnalysis.CommandLine.BuildClient.Run(IEnumerable`1 arguments, RequestLanguage language, CompileFunc compileFunc, CompileOnServerFunc compileOnServerFunc, ICompilerServerLogger logger)
   at Microsoft.CodeAnalysis.CSharp.CommandLine.Program.MainCore(String[] args)
   at Microsoft.CodeAnalysis.CSharp.CommandLine.Program.Main(String[] args)
