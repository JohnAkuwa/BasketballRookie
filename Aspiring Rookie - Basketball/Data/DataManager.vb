﻿Imports System.IO
Imports Aspiring_Rookie___Basketball.Domain
Imports Newtonsoft.Json

Namespace Data
    Public Module DataManager
        Private Const ShopItemsListLocation As String = "D:\Documents\Aspiring Rookie - Basketball\Aspiring Rookie - Basketball\Data\GameConfig\ShopItems.json"
        Private Const TeamListLocation As String = "D:\Documents\Aspiring Rookie - Basketball\Aspiring Rookie - Basketball\Data\CurrentGame\Teams.json"
        Private Const NewTeamListLocation As String = "D:\Documents\Aspiring Rookie - Basketball\Aspiring Rookie - Basketball\Data\GameConfig\NewTeams.json"

        Public Function GetAllShopItems() As List(Of ShopItem)
            Dim json As String = File.ReadAllText(ShopItemsListLocation)
            Dim result = JsonConvert.DeserializeObject(Of List(Of ShopItem))(json)
            Return result
        End Function

        Public Function GetTeamData() As List(Of Team)
            Dim json As String = File.ReadAllText(TeamListLocation)
            Dim result = JsonConvert.DeserializeObject(Of List(Of Team))(json)
            Return result
        End Function

        Public Function GetNewTeamData() As List(Of Team)
            Dim json As String = File.ReadAllText(NewTeamListLocation)
            Dim result = JsonConvert.DeserializeObject(Of List(Of Team))(json)
            Return result
        End Function

        Public Sub SaveGameData()

        End Sub

        Public Function LoadGameData() As GameObjects

        End Function
    End Module
End Namespace