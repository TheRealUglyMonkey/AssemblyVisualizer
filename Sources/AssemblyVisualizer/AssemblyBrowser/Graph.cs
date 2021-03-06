﻿// Copyright 2011 Denis Markelov
// This code is distributed under Microsoft Public License 
// (for details please see \docs\Ms-PL)

using System;
using AssemblyVisualizer.AssemblyBrowser.ViewModels;
using AssemblyVisualizer.Controls.Graph;
using AssemblyVisualizer.Controls.Graph.QuickGraph;

namespace AssemblyVisualizer.AssemblyBrowser
{
	internal class TypeGraph : BidirectionalGraph<TypeViewModel, Edge<TypeViewModel>>
	{
		public TypeGraph(bool allowParallelEdges) : base(allowParallelEdges)
		{
		}
	}

	internal class TypeGraphLayout : GraphLayout<TypeViewModel, Edge<TypeViewModel>, TypeGraph>
	{
		public event Action LayoutFinished;

		protected override void OnLayoutFinished()
		{
			base.OnLayoutFinished();

			var handler = LayoutFinished;
			if (handler != null)
				handler();
		}
	}
}