using System.IO;
using Facepunch;
using Facepunch.Steps;

namespace Facepunch.Pipelines;

internal class Artifacts
{
	public static Pipeline Create()
	{
		var builder = new PipelineBuilder( "Artifacts" );
		builder.AddStep( new DownloadPublicArtifacts( "Download Public Artifacts" ) );
		return builder.Build();
	}
}
