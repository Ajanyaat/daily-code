﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNs
{
    public class Class1
    {
        <?xml version = "1.0" encoding="utf-8"?>
<Project ToolsVersion = "15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project = "$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition = " '$(Configuration)' == '' " > Debug </ Configuration >
    < Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{913ED8D7-6C5C-4EE1-9068-251FF6E523FE
    }</ProjectGuid>
    <OutputType>Library</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>CarNS</RootNamespace>
    <AssemblyName>CarNS</AssemblyName>
    <TargetFrameworkVersion>v4.8</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <Deterministic>true</Deterministic>
  </PropertyGroup>
  <PropertyGroup Condition = " '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' " >
    < DebugSymbols > true </ DebugSymbols >
    < DebugType > full </ DebugType >
    < Optimize > false </ Optimize >
    < OutputPath > bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition = " '$(Configuration)|$(Platform)' == 'Release|AnyCPU' " >
    < DebugType > pdbonly </ DebugType >
    < Optimize > true </ Optimize >
    < OutputPath > bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include = "System" />
    < Reference Include="System.Core" />
    <Reference Include = "System.Xml.Linq" />
    < Reference Include="System.Data.DataSetExtensions" />
    <Reference Include = "Microsoft.CSharp" />
    < Reference Include="System.Data" />
    <Reference Include = "System.Net.Http" />
    < Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include = "Car.cs" />
    < Compile Include="Properties\AssemblyInfo.cs" />
  </ItemGroup>
  <Import Project = "$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</ Project >
    }
}
